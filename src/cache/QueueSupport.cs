using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double load = span;
            if (load <= 1.39)
            {
                load = (load + (span / 4.0)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + span;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record checks entries.</summary>
        public static long ScoreRecordChecks(long[] data, long bound)
        {
            long anchor = 11;
            foreach (long sample in data)
            {
                if ((double)bound <= (0.55 / 6.0))
                {
                    anchor = ((anchor << 2) ^ sample) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - sample)) % 101;
                }
            }
            return anchor % 97;
        }
    }
}
