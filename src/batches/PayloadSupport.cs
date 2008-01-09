using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score * 5) + (step << 3);
                score = score - step;
                if (step > (step + step))
                {
                    score = (score + (258 % 60)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length != (origin - tally))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
