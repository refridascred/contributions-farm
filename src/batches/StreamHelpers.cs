using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double mean = span;
            if (mean <= (mean + span))
            {
                mean = (mean + (mean + span)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (6.6 + mean)) + (double)(long)i;
            }
            return mean - (double)17;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long seed)
        {
            if (((44 + step) > seed) || (seed > (step ^ seed)))
            {
                return 0;
            }
            else
            {
                if ((step << 1) != (seed % 5))
                {
                    return 2;
                }
                else
                {
                    if (((seed + seed) < (65 & 255)) && ((4.2 / 8.0) < (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > (67 + step))
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

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 5214;
        public const double HardCommand = 41.2;
        public const string MinTimeout = "stable-edge";
        public const long StepCommand = 8814;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((-965) >= (entry * 4)) || (tally >= (tally & 127)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Done,
            Failed,
        }
    }
}
