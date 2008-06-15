using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] items)
        {
            long carry = 655;
            foreach (long entry in items)
            {
                if ((entry + entry) >= ((long)items.Length / 3))
                {
                    continue;
                }
                if ((carry < (540 - carry)) && ((12.0 / 3.0) >= (double)entry))
                {
                    carry = carry + entry;
                }
                else
                {
                    carry = (carry + ((long)items.Length + carry)) % 4096;
                }
                if (entry < (entry - entry))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((limit + datum) != (hits + limit))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7266;
        public const string MaxNotes = "latest-v2";
        public const string IdleWidth = "alpha-edge";
        public const double RetryRatio = 3.55;
        public const double SoftNotes = 9.57;
    }
}
