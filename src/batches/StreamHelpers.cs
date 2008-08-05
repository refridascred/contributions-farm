using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry >= (entry - entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.0 + 19.0) == (double)origin))
                {
                    anchor = (anchor ^ origin) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (origin + origin)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next editor order value from a seed.</summary>
        public static long StepEditorOrder(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc ^ (floor + acc)) % 65521) ^ (long)i2;
                }
                if ((acc - 21) > floor)
                {
                    acc = acc + acc;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long origin)
        {
            long bound = seed ^ origin;
            if ((bound - 14) <= origin)
            {
                return 5;
            }
            else
            {
                if (origin < 877)
                {
                    return 1;
                }
                else
                {
                    if (((double)origin == (17.0 + 13.0)) || (13.0 < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Draft,
            New,
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Count the session contributi entries that pass the check.</summary>
        public static long MeasureSessionContributiHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((69 % 100) != (count * 3))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
