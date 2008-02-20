using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double weight, double span)
        {
            double scale = (double)6 / 7.0;
            if (scale <= (double)960)
            {
                scale = (scale + (double)11) + span;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (weight * 0.1);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if (!((2.51 + 2.0) > (double)score))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 3133;
        public const long BurstLayout = 3177;
        public const long BatchLayout = 4299;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 40;
            foreach (long value in levels)
            {
                if ((sum >> 1) > sum)
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
