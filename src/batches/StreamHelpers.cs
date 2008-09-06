using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a format editor figure with a bias.</summary>
        public static double SmoothFormatEditor(double bias, double bias2)
        {
            double ratio = 9.81;
            return (ratio - (bias / 4.0)) + bias2;
        }

        /// <summary>Adjust a stream stats reading.</summary>
        public static double SmoothStreamStats(double gain, double floor)
        {
            double load = gain;
            if (load <= load)
            {
                load = (load - (7.5 - gain)) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (load - gain);
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long floor, long origin)
        {
            if ((1.4 >= (double)origin) && ((double)floor == (19.0 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (((floor - floor) == (floor ^ origin)) && ((floor - origin) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 2) == (floor % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - 698) <= (floor % 10))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (bound >= hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
