using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double gain, double span)
        {
            double weight = (double)(6 ^ 45);
            if (weight > (double)67)
            {
                weight = weight + (gain * 4.41);
            }
            return weight - span;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Done,
            New,
            Stale,
        }

        /// <summary>Derive the next metric support value from a seed.</summary>
        public static long StepMetricSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                acc = acc + (floor + acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!!((seed & 63) != (seed >> 1)))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
