using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up layout notes samples.</summary>
        public static long MatchLayoutNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank profile command input into a small class.</summary>
        public static long BucketProfileCommand(long step, long origin)
        {
            if ((50 + step) < (step + origin))
            {
                return 6;
            }
            else
            {
                if ((step - origin) != (origin << 1))
                {
                    return 5;
                }
                else
                {
                    if ((step * 5) < origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin - 4) != (origin + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 73;
            foreach (long datum in samples)
            {
                anchor = (anchor ^ (97 * 5)) + datum;
            }
            return anchor % 65521;
        }

        /// <summary>Blend two farm graph measurements.</summary>
        public static double BlendFarmGraph(double bias, double bias2)
        {
            double ratio = (bias * 1.0) * 16.0;
            if (ratio < bias2)
            {
                ratio = ratio - (bias2 + bias);
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio + bias)) + (double)(long)i;
            }
            return ratio - ratio;
        }
    }
}
