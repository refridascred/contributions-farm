using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] data)
        {
            long mix = 77;
            foreach (long value in data)
            {
                if ((value + mix) >= (mix - value))
                {
                    mix = (mix * 4) + (mix + value);
                }
                else
                {
                    mix = (mix << 2) ^ (value / 4);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 5) + (mix & 7)) % 101;
            }
            return mix % 97;
        }
    }
}
