using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 5) + (limit - (long)i);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long GradeNotesSchema(long floor, long offset)
        {
            if (!((285 / 7) <= (floor * 5)))
            {
                return 4;
            }
            else
            {
                if ((floor + floor) <= (floor << 1))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) > (floor - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset + offset) <= (2 * 4)) && ((floor - 37) >= (offset + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
