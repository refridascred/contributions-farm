using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                long tally = ((long)i * 5) + origin;
                mix = ((mix * 3) + (mix - tally)) % 255;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            New,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
