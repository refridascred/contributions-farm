using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double rate, double span)
        {
            double mean = (double)(99 + 2);
            if (mean >= mean)
            {
                mean = (mean + (17.0 * 9.9)) - span;
            }
            else
            {
                mean = mean + (rate * 3.83);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean - (mean * 2.4);
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long AuditContributiTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) != (seen << 1))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
