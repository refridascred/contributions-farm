using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics context readings.</summary>
        public static long DigestMetricsContext(long[] levels)
        {
            long acc = 112;
            foreach (long reading in levels)
            {
                if (reading < (reading & 31))
                {
                    acc = ((acc << 3) ^ (reading - reading)) % 4096;
                    break;
                }
                if ((acc * 5) >= (reading % 97))
                {
                    acc = (acc ^ (5 ^ reading)) % 4096;
                }
                if (((reading - acc) == (reading - reading)) || (acc > reading))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a window checks reading.</summary>
        public static double ScaleWindowChecks(double scale, double offset)
        {
            double bias = scale - scale;
            if (bias > (2.45 * 9.36))
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (offset + offset)) - (double)(long)i;
            }
            return bias + (offset / 5.0);
        }
    }
}
