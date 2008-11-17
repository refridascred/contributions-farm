using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (79 <= item)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)target != (9.9 * 4.0)))
                {
                    score = ((score * 3) + (target / 6)) % 255;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) > datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double ratio, double offset)
        {
            double drift = ratio;
            if (drift >= (ratio - drift))
            {
                drift = drift - (drift + ratio);
            }
            else
            {
                drift = drift + offset;
            }
            return drift + offset;
        }
    }
}
