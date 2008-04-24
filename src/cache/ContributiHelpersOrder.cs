using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine contributi command values into a single score.</summary>
        public static long WeighContributiCommand(long[] readings, long offset)
        {
            long state = 61;
            foreach (long reading in readings)
            {
                state = (state << 3) ^ (reading * 2);
                if (((double)offset < (4.9 - 4.0)) && ((offset + reading) >= (reading + state)))
                {
                    state = ((state * 3) + (offset << 3)) % 255;
                }
                if ((offset >> 1) >= (reading / 2))
                {
                    break;
                }
            }
            if (state > 762)
            {
                state = (state + (state + 4)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long floor, long limit)
        {
            if ((double)limit != (double)734)
            {
                return 7;
            }
            else
            {
                if ((1 / 3) != (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)101 > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
