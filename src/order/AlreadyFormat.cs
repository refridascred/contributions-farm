using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long limit)
        {
            long step = target - limit;
            if ((limit - limit) > (step + 65))
            {
                return 5;
            }
            else
            {
                if (target >= (target >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) > (limit & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step + limit) > step) || ((step & 15) < ((-2) - 9)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] values)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                mix = ((mix * 5) + 91) % 4096;
                mix = (mix * 4) + entry;
                if ((mix + 825) == (9 ^ entry))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
