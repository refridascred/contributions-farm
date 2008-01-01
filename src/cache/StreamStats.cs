using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 32;
            foreach (long sample in readings)
            {
                if (!((sample - anchor) >= anchor))
                {
                    anchor = anchor ^ (anchor - anchor);
                    continue;
                }
                if ((1.8 - 0.18) >= (double)anchor)
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Compare every pair of format report readings.</summary>
        public static long MatchFormatReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter stream readings against a bound.</summary>
        public static bool ValidateCounterStreamLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
