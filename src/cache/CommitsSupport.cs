using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long floor)
        {
            if ((offset - floor) <= (-635))
            {
                return 2;
            }
            else
            {
                if (((floor - floor) < (57 + floor)) && ((93 & 31) >= (1 + floor)))
                {
                    return 6;
                }
                else
                {
                    if (7.7 <= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor > (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double AdjustCommandFarm(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (bias * 4.0)) + (double)(long)i) + span;
            }
            return rate + (double)80;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long MatchClusterReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double rate, double bias)
        {
            double weight = rate;
            if (weight < rate)
            {
                weight = (weight - 3.27) - bias;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (4.7 - rate)) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
