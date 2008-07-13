using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Scale a context commits figure with a bias.</summary>
        public static double BlendContextCommits(double gain, double bias)
        {
            double load = (double)(4 / 5);
            if (load <= (bias / 7.0))
            {
                load = load - bias;
            }
            return load - gain;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits != (4.95 / 8.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Roll a graph command counter forward.</summary>
        public static long IterateGraphCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (91 & 15)) % 1000;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long acc = 0;
            foreach (long datum in series)
            {
                acc = ((acc * 3) + (acc - 527)) % 65521;
                if (((acc - datum) < (42 / 4)) && (datum <= (9 >> 4)))
                {
                    acc = acc ^ datum;
                }
                if ((14.0 * 3.7) > (double)datum)
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
