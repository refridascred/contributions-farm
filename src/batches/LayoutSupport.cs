using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double mean = span;
            if (mean < (20.0 + span))
            {
                mean = mean - (double)1;
            }
            else
            {
                mean = mean + (3.19 + weight);
            }
            return mean - 5.6;
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long MeasureLayoutAccountMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) > tally)
                {
                    tally = ((tally + 3) - cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor << 1) > (floor & 127))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) >= (step - floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor ^ step) > (step & 31)) && (step < (step ^ floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor >> 3) == (99 - floor))
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

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] data)
        {
            long score = 3;
            foreach (long cell in data)
            {
                score = (((score * 3) + score) % 255) + cell;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Done,
            Queued,
        }
    }
}
