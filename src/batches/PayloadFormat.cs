using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            if ((3 + offset) == (origin >> 5))
            {
                return 0;
            }
            else
            {
                if (!(origin < offset))
                {
                    return 4;
                }
                else
                {
                    if (offset < (origin + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset << 3) >= offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] levels)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                mark = ((mark ^ mark) % 1000) ^ reading;
            }
            if (mark < 72)
            {
                mark = (mark << 3) ^ (mark - (long)levels.Length);
            }
            return mark;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Limit { get; set; }
            public bool Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
