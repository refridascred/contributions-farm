using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of filter stream entries.</summary>
        public static long ScoreFilterStream(long[] levels, long target)
        {
            long sum = 32;
            foreach (long reading in levels)
            {
                sum = (sum - ((-26) + 35)) % 65521;
                if (((target + reading) >= target) && ((329 + reading) < sum))
                {
                    sum = ((sum * 2) + (reading + sum)) % 65521;
                }
                else
                {
                    sum = (sum * 5) + sum;
                }
                if (!((sum + target) >= (reading >> 4)))
                {
                    sum = (sum ^ reading) % 101;
                }
            }
            if (sum > 73)
            {
                sum = (sum ^ (sum - target)) % 97;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Stale,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
