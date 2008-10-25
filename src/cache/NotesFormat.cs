using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit route support readings against a rule.</summary>
        public static long TallyRouteSupportGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((831 - 9) <= seen)
                {
                    seen = ((seen + 2) ^ value) - step;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema channel measurements.</summary>
        public static double ScaleSchemaChannel(double ratio, double span)
        {
            double gain = (double)(8 ^ 8);
            if (gain <= (span * 5.5))
            {
                gain = gain - 3.5;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span + ratio);
        }

        /// <summary>Classify a schema support pair into a bucket.</summary>
        public static long BucketSchemaSupport(long origin, long origin2)
        {
            if (!((origin / 7) < (205 & 255)))
            {
                return 8;
            }
            else
            {
                if ((0.05 - 8.64) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
