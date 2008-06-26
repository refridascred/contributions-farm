using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((20.0 / 7.0) > (double)sum))
                {
                    sum = (sum << 2) ^ ((long)i / 9);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of commits cache readings.</summary>
        public static long WeighCommitsCache(long[] samples)
        {
            long anchor = 913;
            foreach (long reading in samples)
            {
                if (((double)reading != (double)anchor) && (((-56) - reading) > (-424)))
                {
                    anchor = (anchor - reading) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
