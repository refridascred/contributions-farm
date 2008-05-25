using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long seed)
        {
            if (((origin % 24) < seed) && ((origin - origin) >= (origin ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((7 < (origin + 7)) || ((origin >> 4) > 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metrics schema entries.</summary>
        public static long DigestMetricsSchema(long[] samples, long step)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                if (sum <= (value + 29))
                {
                    sum = (sum ^ value) + step;
                }
                else
                {
                    sum = sum - value;
                }
                if ((double)sum <= (5.6 - 9.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
