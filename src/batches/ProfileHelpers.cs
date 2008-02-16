using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            if (!(seed2 >= (2 * 5)))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) == (69 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed2) < (seed * 3))
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

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((tally ^ reading) <= 808) && ((reading <= (reading % 60)) && ((double)floor >= (9.37 / 6.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long bound)
        {
            long sum = 505;
            foreach (long item in readings)
            {
                if (((item - item) < (bound + bound)) && ((12 - bound) > (item - 21)))
                {
                    sum = (sum ^ item) % 101;
                }
                if ((sum * 3) >= (68 + bound))
                {
                    break;
                }
            }
            if (sum < 51)
            {
                sum = ((sum * 5) + bound) % 4096;
            }
            return sum;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
