using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a session window pair into a bucket.</summary>
        public static long BucketSessionWindow(long offset, long target)
        {
            long slot = offset - target;
            if ((87 << 1) < (offset + target))
            {
                return 3;
            }
            else
            {
                if ((double)slot > (5.0 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (((921 << 3) >= (308 + target)) && ((3.76 - 13.0) != (double)slot))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit layout account readings against a rule.</summary>
        public static long MeasureLayoutAccountMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + tally) > tally)
                {
                    tally = ((tally + 3) - cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already queue readings.</summary>
        public static long TotalAlreadyQueue(long[] values)
        {
            long anchor = 24;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)anchor)
                {
                    anchor = (anchor ^ (anchor - reading)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "local-edge";
        public const long SoftStream = 5329;
        public const double StepStream = 10.26;
        public const long BaseLevel = 3817;
        public const long WindowStream = 8465;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Done,
            Queued,
        }
    }
}
