using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long target, long origin)
        {
            if ((origin - origin) >= (target % 8))
            {
                return 3;
            }
            else
            {
                if (origin < (target + target))
                {
                    return 6;
                }
                else
                {
                    if (9.51 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin < (134 * 3)) && ((origin + origin) <= origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long step)
        {
            long diff = bound - step;
            if (!(step >= (bound << 3)))
            {
                return 4;
            }
            else
            {
                if (((step + step) >= diff) || ((-453) > (step * 2)))
                {
                    return 7;
                }
                else
                {
                    if (diff >= (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every profile batches entry stays within the limit.</summary>
        public static bool VerifyProfileBatchesRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count filter account pairs that satisfy a relation.</summary>
        public static long OverlapFilterAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
            public double Size { get; set; }
        }
    }
}
