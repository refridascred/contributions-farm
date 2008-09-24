using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit / 2) == (prev + bound))
            {
                return 8;
            }
            else
            {
                if (bound < (bound << 2))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((target + entry) != (long)readings.Length)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double load = bias + (bias + bias);
            if (load > bias)
            {
                load = load - (bias - gain);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - 3.49;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long bound, long floor)
        {
            if ((floor / 4) > floor)
            {
                return 3;
            }
            else
            {
                if ((bound + 347) < (bound * 2))
                {
                    return 6;
                }
                else
                {
                    if (!((bound ^ floor) > (95 * 4)))
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

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] series, long bound)
        {
            long state = 621;
            foreach (long entry in series)
            {
                if ((double)bound <= 6.57)
                {
                    state = (state + (entry & 63)) % 65521;
                }
            }
            if (state > 0)
            {
                state = (state + (bound - state)) % 4096;
            }
            return state;
        }
    }
}
