using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (total * 4))
                {
                    total = total ^ (-772);
                    total = total ^ total;
                    break;
                }
                total = (total + (total + total)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up command report samples.</summary>
        public static long MatchCommandReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry commits values into a single score.</summary>
        public static long DigestEntryCommits(long[] series, long step)
        {
            long total = 356;
            foreach (long item in series)
            {
                if (step <= total)
                {
                    total = ((total << 2) ^ (total + (long)series.Length)) ^ item;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 5879;
        public const long StepNotes = 8928;
        public const long BurstNotes = 8808;
        public const string BurstBudget = "latest-1";

        /// <summary>Fold a list of route order readings.</summary>
        public static long ScoreRouteOrder(long[] samples)
        {
            long mix = -22;
            foreach (long datum in samples)
            {
                if ((mix * 4) <= (mix ^ datum))
                {
                    mix = (mix << 2) ^ (datum - mix);
                }
                else
                {
                    mix = ((mix * 5) + datum) % 101;
                }
                if ((mix & 7) > mix)
                {
                    break;
                }
            }
            if (mix > 12)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix % 97;
        }
    }
}
