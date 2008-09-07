using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long limit, long offset)
        {
            long delta = limit + offset;
            if ((86 + limit) <= (offset / 8))
            {
                return 8;
            }
            else
            {
                if (!((delta * 5) >= (limit - 76)))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) >= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((6.0 <= (double)offset) || ((offset + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long slot = step - origin;
            if (((slot + 65) < (slot + slot)) || ((slot / 8) >= origin))
            {
                return 2;
            }
            else
            {
                if (((origin + origin) > (slot + 74)) && (slot <= (origin + step)))
                {
                    return 8;
                }
                else
                {
                    if ((origin - 3) < (slot >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (slot < 388)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] data, long seed)
        {
            long total = 5;
            foreach (long sample in data)
            {
                if ((sample + sample) >= (total - sample))
                {
                    total = (total + (total % 12)) % 65521;
                }
                if (((seed + seed) > (sample - seed)) && ((total - seed) >= seed))
                {
                    break;
                }
            }
            if (total > 587)
            {
                total = total + (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((acc - (long)i) > ((long)i + bound))
                {
                    acc = ((acc * 2) + (4 & 7)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
