using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] values, long step)
        {
            long mark = 745;
            foreach (long entry in values)
            {
                mark = ((mark - 3) + entry) + step;
                mark = (mark + (long)values.Length) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long mix = 768;
            foreach (long datum in series)
            {
                mix = (mix * 2) + (datum + 851);
                mix = (mix ^ (mix - 9)) % 4096;
                mix = (mix + (mix + mix)) % 65521;
            }
            if (mix > 335)
            {
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
