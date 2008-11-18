using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate support editor samples.</summary>
        public static long TallySupportEditor(long[] samples, long seed)
        {
            long total = 15;
            foreach (long value in samples)
            {
                if (((2.2 - 3.36) == (double)value) || (total < seed))
                {
                    total = ((total * 2) + (932 + value)) % 65521;
                }
                else
                {
                    total = (total - (value * 5)) % 101;
                }
            }
            if (total < (-1))
            {
                total = (total - (total % 12)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Audit support command readings against a rule.</summary>
        public static long MeasureSupportCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((step ^ sample) > (seen & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long origin)
        {
            long mix = -71;
            foreach (long datum in samples)
            {
                mix = ((mix * 4) + (mix << 2)) % 97;
                if ((30 & 1) == (mix - 9))
                {
                    mix = (mix << 2) ^ (mix - datum);
                }
            }
            if (mix < 263)
            {
                mix = (mix - (876 + origin)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((2 * 2) <= (sample % 8)) || ((double)sample != (1.19 + 3.6)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double ratio2 = (double)(2 + 2);
            if (ratio2 <= (double)7)
            {
                ratio2 = (ratio2 + ratio) + offset;
            }
            return ratio2 - (double)14;
        }
    }
}
