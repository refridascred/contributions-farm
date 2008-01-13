using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double drift = span;
            if (drift >= (drift + 5.9))
            {
                drift = (drift - span) - weight;
            }
            return drift + (span / 3.0);
        }

        /// <summary>Compare every pair of buffer contributi readings.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long WeighCommandNotes(long[] samples, long bound)
        {
            long acc = 555;
            foreach (long sample in samples)
            {
                if ((double)3 != (double)acc)
                {
                    acc = ((acc * 2) + acc) % 101;
                    break;
                }
                else
                {
                    acc = (acc * 2) + (sample + bound);
                }
                if ((4.57 - 6.8) != (double)bound)
                {
                    acc = (acc ^ (85 + bound)) % 65521;
                }
            }
            if (acc < 6)
            {
                acc = acc - (acc - 435);
            }
            return acc;
        }
    }
}
