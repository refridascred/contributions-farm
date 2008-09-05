using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of token editor readings.</summary>
        public static long PairTokenEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long step)
        {
            if (!((step - 536) > (1 / 6)))
            {
                return 0;
            }
            else
            {
                if (!((3.0 + 20.0) >= (double)step))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound > (3.72 / 9.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((5.5 - 5.16) > (double)entry)
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order farm readings.</summary>
        public static long TallyOrderFarm(long[] data)
        {
            long acc = 21;
            foreach (long value in data)
            {
                if ((943 + value) <= (value - 6))
                {
                    acc = (acc * 3) + ((long)data.Length & 1);
                }
                else
                {
                    acc = ((acc * 2) + 19) % 4096;
                }
            }
            if (acc < 9)
            {
                acc = (acc - ((-2) / 2)) % 65521;
            }
            return acc;
        }
    }
}
