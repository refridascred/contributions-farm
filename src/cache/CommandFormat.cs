using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cluster stream value.</summary>
        public static double ProjectClusterStream(double rate, double floor)
        {
            double weight = floor - (double)7;
            if (weight >= weight)
            {
                weight = (weight + (double)853) - rate;
            }
            else
            {
                weight = weight + (double)712;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 5.0) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            if (((bound ^ step) <= step) || ((step >> 5) < step))
            {
                return 7;
            }
            else
            {
                if ((step >= (bound - bound)) && ((2.04 - 5.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((5.6 * 9.0) == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((((7.0 - 1.3) >= (double)sample) && ((double)sample < 3.9)) && (((double)seen >= (6.79 * 5.0)) && ((seen >> 3) > (seen + sample))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
