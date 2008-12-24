using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((bound & 127) != (seen + bound))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry < (entry * 2))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double rate, double bias)
        {
            double mean = bias * 7.43;
            return (mean + (9.44 + bias)) + rate;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long GradeContributiCommits(long origin, long step)
        {
            if (!((origin >> 2) < (35 - origin)))
            {
                return 8;
            }
            else
            {
                if ((step > (origin + origin)) && ((origin << 3) == (step + step)))
                {
                    return 7;
                }
                else
                {
                    if (((step - origin) != (step & 255)) && ((origin - step) <= (step + origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step >= (3 - origin)) && ((step / 3) == (step + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
