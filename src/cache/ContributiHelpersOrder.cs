using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Retry,
            Idle,
            Draft,
            Pending,
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

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
