using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long ClassifyCommitsCounter(long bound, long step)
        {
            if (step < bound)
            {
                return 4;
            }
            else
            {
                if (step <= (step + bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound * 3) > (bound + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi window samples are out of range.</summary>
        public static long TallyContributiWindowHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((double)tally == (double)item) || ((double)tally < 9.94))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
