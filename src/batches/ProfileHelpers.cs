using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((3.4 / 6.0) > (double)hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (((-6) % 10) <= (entry % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every checks account entry stays within the limit.</summary>
        public static bool ValidateChecksAccountRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two already cluster measurements.</summary>
        public static double BlendAlreadyCluster(double weight, double offset)
        {
            double load = weight;
            if (load <= offset)
            {
                load = load - load;
            }
            else
            {
                load = load + (load + 19.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up profile farm samples.</summary>
        public static long MatchProfileFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
