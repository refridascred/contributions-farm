using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] samples)
        {
            long mark = 391;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (mark - datum)) % 97;
                if (((datum & 15) != (datum * 4)) || (datum >= (datum ^ mark)))
                {
                    mark = ((mark << 3) ^ (datum & 31)) % 101;
                }
            }
            if (mark > (-98))
            {
                mark = mark ^ (111 & 127);
            }
            return mark;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two report cache measurements.</summary>
        public static double ScaleReportCache(double bias, double span)
        {
            double gain = (double)(138 << 1);
            if (gain <= (double)90)
            {
                gain = ((gain + 9.64) - bias) + span;
            }
            return gain - gain;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((origin + result) < (origin / 2)) && (((long)i ^ origin) >= (origin - origin))))
                {
                    result = (result + (origin + result)) % 97;
                }
                result = result ^ (origin * 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
