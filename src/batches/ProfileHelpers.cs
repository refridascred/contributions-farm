using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long step, long step2)
        {
            if ((12.0 / 8.0) >= (double)step2)
            {
                return 8;
            }
            else
            {
                if (((9.07 + 6.95) != (double)step) && ((step ^ step) > (step ^ step2)))
                {
                    return 1;
                }
                else
                {
                    if (step >= (38 - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double drift = (double)(67 % 97);
            if (drift >= (bias + drift))
            {
                drift = (drift - (double)(-2)) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - (double)859;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] samples)
        {
            long total = 133;
            foreach (long item in samples)
            {
                if (!((total & 1) > (total - total)))
                {
                    total = ((total - 9) % 1000) ^ item;
                }
            }
            if (total < (-482))
            {
                total = (total - total) % 255;
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((reading - 10) != (count >> 3)) && ((reading * 5) >= (count << 3))) || ((9.94 + 18.0) >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
