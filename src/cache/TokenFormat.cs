using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a payload graph reading.</summary>
        public static double BlendPayloadGraph(double gain, double offset)
        {
            double bias = (gain * 0.91) / 2.0;
            if (bias <= (double)1)
            {
                bias = bias - (double)81;
            }
            else
            {
                bias = bias + (offset - offset);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (offset / 2.0)) - (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long MeasureContributiToolsHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally + tally) > tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }
    }
}
