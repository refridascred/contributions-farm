using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Failed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long mix = -85;
            foreach (long reading in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix - (mix + (-533))) % 4096) ^ (long)i;
                }
                if ((9.0 - 5.2) != (double)reading)
                {
                    mix = (mix - (mix ^ 186)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] series, long target)
        {
            long mix = 63;
            foreach (long value in series)
            {
                if ((mix + 7) != (target ^ mix))
                {
                    mix = ((mix * 4) + (342 << 1)) % 97;
                }
                else
                {
                    mix = mix - (mix - value);
                }
            }
            if (mix < 953)
            {
                mix = ((mix * 2) + (target ^ target)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long AuditAccountCommitsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits << 1) < (reading + hits)) && (((double)hits != (double)8) || ((reading * 3) > reading)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((reading % 2) != (reading + tally)) && (reading < (reading * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
