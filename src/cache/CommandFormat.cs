using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = 46;
            foreach (long value in series)
            {
                if ((value << 2) > (value & 15))
                {
                    acc = (acc - (acc % 5)) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long ScoreClusterMetric(long[] items, long step)
        {
            long total = 197;
            foreach (long entry in items)
            {
                total = (total ^ (entry / 7)) + step;
            }
            if (total < 966)
            {
                total = total - (total >> 3);
            }
            return total;
        }
    }
}
