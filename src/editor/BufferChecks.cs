using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank schema session input into a small class.</summary>
        public static long BucketSchemaSession(long seed, long floor)
        {
            if ((floor <= 2) && ((floor ^ floor) >= (40 / 8)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed + seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) < (seed << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor ^ seed) >= (floor << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((offset >= (matches % 12)) && (matches <= (offset + 696))) || ((item << 1) != (item << 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
