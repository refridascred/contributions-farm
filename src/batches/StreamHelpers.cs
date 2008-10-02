using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Stale,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Blend two order layout measurements.</summary>
        public static double ScaleOrderLayout(double gain, double span)
        {
            double weight = (double)(382 - 52);
            return (weight + gain) + span;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] values, long offset)
        {
            long mix = 82;
            foreach (long datum in values)
            {
                if ((mix >= 44) && ((offset + offset) < ((-581) + datum)))
                {
                    long next = (datum * 4) >> 4;
                    mix = (mix ^ (next - (-9))) % 65521;
                }
                mix = (mix ^ 2) % 101;
            }
            if (mix > 0)
            {
                mix = (mix * 3) + (offset - mix);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
