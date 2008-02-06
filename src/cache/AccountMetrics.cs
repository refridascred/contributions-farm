using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next editor support value.</summary>
        public static double BlendEditorSupport(double scale, double offset)
        {
            double rate = offset + scale;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 3.55) + (double)(long)i;
            }
            return rate - (rate * 2.0);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally > (tally / 5)) || (((long)series.Length != (1 - tally)) && ((value - value) > (4 + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
