using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double gain = span;
            if (gain >= span)
            {
                gain = (gain + gain) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (span * 7.85);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] values, long bound)
        {
            long acc = 78;
            foreach (long datum in values)
            {
                acc = ((acc * 5) + acc) + datum;
                if ((19.0 / 2.0) < (8.17 / 8.0))
                {
                    acc = (acc * 4) + (bound % 97);
                }
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchScore = 5214;
        public const double HardCommand = 41.2;
        public const string MinTimeout = "stable-edge";
        public const long StepCommand = 8814;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((-965) >= (entry * 4)) || (tally >= (tally & 127)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Locked,
            Done,
            Failed,
        }
    }
}
