using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank editor support input into a small class.</summary>
        public static long ClassifyEditorSupport(long floor, long origin)
        {
            long offset = floor + origin;
            if ((floor + floor) <= (origin / 3))
            {
                return 7;
            }
            else
            {
                if (6 >= origin)
                {
                    return 0;
                }
                else
                {
                    if (!((986 + floor) < 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) != (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] items)
        {
            long sum = 76;
            foreach (long sample in items)
            {
                sum = ((sum << 2) ^ (sample - sample)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Paused,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Look up the position of a notes counter sample.</summary>
        public static long FindNotesCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 97);
            if (gain2 <= (span - gain))
            {
                gain2 = gain2 - (gain2 * 1.4);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain + gain2)) + (double)(long)i;
            }
            return gain2 + (double)57;
        }
    }
}
