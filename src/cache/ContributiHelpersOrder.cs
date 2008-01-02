using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many queue farm samples are out of range.</summary>
        public static long TallyQueueFarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits * 2) <= (hits - cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a schema command pair into a bucket.</summary>
        public static long RankSchemaCommand(long offset, long step)
        {
            if ((offset ^ step) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((offset + step) >= (303 * 3))
                {
                    return 8;
                }
                else
                {
                    if (!((step * 3) < (step / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + step) >= (offset + offset))
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
    }
}
