using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches - (long)readings.Length) != (matches + (long)readings.Length)) || ((matches ^ entry) <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long step)
        {
            if ((seed >= 17) && ((seed % 12) >= (step / 7)))
            {
                return 8;
            }
            else
            {
                if (8 <= (step - seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed != (double)(-82))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((11.0 + 9.68) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
            public double Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
