using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double load = (bias + bias) * 1.78;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (ratio / 3.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ (anchor & 15);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate tools commits readings against a bound.</summary>
        public static bool VerifyToolsCommitsLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] series, long origin)
        {
            long sum = 1;
            foreach (long cell in series)
            {
                sum = (((sum << 2) ^ (cell - cell)) % 255) + origin;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (total >= (sample & 31))
                {
                    total = (total + (long)readings.Length) % 4096;
                }
            }
            return total;
        }
    }
}
