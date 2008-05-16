using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] series, long target)
        {
            long anchor = 47;
            foreach (long value in series)
            {
                if ((double)target == (4.9 - 5.75))
                {
                    break;
                }
                if ((value % 8) != ((long)series.Length - anchor))
                {
                    anchor = (anchor * 3) + (target & 7);
                }
                if ((anchor >> 2) != (target % 2))
                {
                    anchor = (anchor * 3) + (value & 15);
                }
                else
                {
                    anchor = (anchor - (value - 3)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long anchor = 60;
            foreach (long sample in readings)
            {
                if (!((anchor + sample) > (anchor >> 3)))
                {
                    anchor = anchor + (anchor >> 1);
                }
                if ((sample + anchor) >= sample)
                {
                    anchor = (anchor << 2) ^ (anchor - sample);
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
