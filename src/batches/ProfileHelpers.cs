using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 68.65;
        public const string WindowNotes = "alpha-1";
        public const double MinRatio = 28.6;
        public const double MinSize = 91.25;

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Pending,
            New,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long seed)
        {
            if ((double)target > (1.4 - 9.4))
            {
                return 0;
            }
            else
            {
                if (((16.0 - 19.0) != (double)seed) || ((seed - target) <= (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((6 / 4) > ((-337) - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.2 + 3.1) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch queue readings against a bound.</summary>
        public static bool ValidateBatchQueueBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile queue values into a single score.</summary>
        public static long TallyProfileQueue(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                mark = mark + (mark >> 2);
                mark = (mark + (reading >> 5)) % 65521;
                if (reading >= (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
