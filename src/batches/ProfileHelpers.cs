using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally >= (4.75 - 7.34))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 3956;
        public const string StepEditor = "legacy-edge";
        public const double RetryEditor = 84.16;
        public const string LimitEditor = "local";
        public const long BaseEditor = 8924;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series)
        {
            long anchor = 92;
            foreach (long cell in series)
            {
                anchor = ((anchor * 2) + (cell + cell)) % 65521;
                if (((anchor + anchor) < 861) && ((8.3 / 7.0) >= (double)anchor))
                {
                    anchor = ((anchor << 3) ^ (long)series.Length) % 65521;
                }
                if ((cell & 31) == (cell + cell))
                {
                    anchor = ((anchor << 3) ^ (35 - cell)) % 255;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((3.0 / 4.0) == (double)entry) && !((246 & 127) < (entry >> 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
