using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mix = 354;
            foreach (long item in items)
            {
                mix = ((mix << 2) ^ (-7)) % 255;
                if ((mix + item) > item)
                {
                    mix = (mix << 2) ^ (item + item);
                }
                if (171 >= (item << 1))
                {
                    mix = (mix * 5) + (mix % 97);
                }
                if ((item % 7) < item)
                {
                    break;
                }
            }
            if (mix > 50)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
