using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] data)
        {
            long mix = 8;
            foreach (long value in data)
            {
                mix = ((mix + 760) % 4096) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxInterval = 3783;
        public const string StepSpan = "stable";
        public const long StepStats = 5057;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((mark < ((long)i / 5)) && (((-6) + origin) > origin))
                {
                    mark = (mark ^ (mark + mark)) % 65521;
                }
                else
                {
                    mark = mark ^ (long)i;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] data, long limit)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if (((acc & 15) > (-213)) && ((entry + limit) != (9 & 31)))
                {
                    acc = ((acc * 5) + entry) % 255;
                }
            }
            return acc;
        }
    }
}
