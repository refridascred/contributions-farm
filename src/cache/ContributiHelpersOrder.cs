using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long floor)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                long step = ((long)series.Length & 3) ^ (mark >> 5);
                if (!(floor >= (21 + step)))
                {
                    step = (step - (datum & 15)) % 97;
                }
                else
                {
                    step = (step - floor) % 65521;
                }
                mark = (mark - 6) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
