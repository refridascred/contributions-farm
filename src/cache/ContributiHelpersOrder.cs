using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph queue value against two limits.</summary>
        public static long RankGraphQueue(long step, long floor)
        {
            if ((double)step != (double)floor)
            {
                return 3;
            }
            else
            {
                if ((596 < step) || ((step + (-7)) >= (step / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step) >= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step < (611 ^ floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
