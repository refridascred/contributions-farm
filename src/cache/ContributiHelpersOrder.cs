using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of order githubfarm readings.</summary>
        public static long TallyOrderGithubfarm(long[] readings)
        {
            long mix = 71;
            foreach (long datum in readings)
            {
                if (datum > (mix - 97))
                {
                    mix = ((mix << 3) ^ (datum >> 3)) % 101;
                }
                else
                {
                    mix = mix + (5 >> 1);
                }
            }
            if (mix < 46)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate account farm samples.</summary>
        public static long FoldAccountFarm(long[] series)
        {
            long sum = 2;
            foreach (long datum in series)
            {
                sum = ((sum - sum) % 97) ^ datum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
