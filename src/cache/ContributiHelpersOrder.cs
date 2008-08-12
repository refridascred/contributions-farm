using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of report stream readings.</summary>
        public static long DigestReportStream(long[] items)
        {
            long mix = 52;
            foreach (long reading in items)
            {
                mix = (mix - (reading & 1)) % 101;
                if (((mix >> 2) < (reading + (-789))) && ((reading - reading) <= (mix << 2)))
                {
                    mix = ((mix * 2) + (reading << 2)) % 255;
                }
                else
                {
                    mix = (mix ^ mix) % 255;
                }
            }
            return mix;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                if (!((double)score >= (6.82 + 8.96)))
                {
                    break;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
