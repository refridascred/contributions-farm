using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph report samples.</summary>
        public static long WeighGraphReport(long[] series)
        {
            long anchor = 40;
            foreach (long entry in series)
            {
                if (((anchor & 1) <= (anchor + anchor)) && (anchor <= (anchor << 2)))
                {
                    anchor = (anchor << 2) ^ entry;
                }
                if (!((anchor / 3) <= (anchor + entry)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit graph record readings against a rule.</summary>
        public static long TallyGraphRecordGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches * 5) == (reading - floor))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepLevel = 9283;
        public const long BaseSize = 1601;
        public const long BaseFormat = 8787;
        public const double MaxSpan = 63.86;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
